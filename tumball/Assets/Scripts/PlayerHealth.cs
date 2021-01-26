using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public static PlayerHealth Instance;

    public float maxHealth = 100f;
    public float currentHealth = 0f;
    public GameObject healthBar;
    public bool alive = true;
    public GameObject gameOverUI;
    public GameObject inGameUI;
    public GameObject adUI;
    public GameObject deathExplosion;
    public Text lifeText;
    private int life;



	// Use this for initialization
	void Start () {
        life = SaveManager.Instance.state.levelLife;
        alive = true;
        currentHealth = maxHealth;
        InvokeRepeating("decreaseHealth", 1f, 1f);
        SetLifeText();
        Instance = this;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void decreaseHealth()
    {
        TakeDamage(1f);

    }

    public void TakeDamage(float damageAmount)
    {
        if (!alive)
        {
            return;
        }
        
        if (currentHealth <= 0)
        {
            alive = false;
            
        }

        currentHealth -= damageAmount;
        SetHealthBar();

        if (alive == false)
        {
            currentHealth = 0;
            death();
           
           
        }

        
    }

    public void RegainHealth(float healAmount)
    {
        currentHealth += healAmount;
            if (currentHealth >= 100)
        {
            currentHealth = maxHealth;
        }
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        float myHealth = currentHealth / maxHealth;
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fall_blocker"))
        {
            death();
            Debug.Log("I hit the fall blocker");
        }
    }

   

    public void death()
    {
        
        //Player explosion effect
        GameObject go = Instantiate(deathExplosion) as GameObject;
        go.transform.position = transform.position;

        //Hide player mesh
        if (gameObject.CompareTag("Player"))
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }

        AudioManager.instance.Play("Death");
        Handheld.Vibrate();

        //Decrease lives
        
        if(SaveManager.Instance.state.levelLife <= 0)
        {
            SaveManager.Instance.state.levelLife = 0;
        }else
        {
            SaveManager.Instance.state.levelLife--;
        }
        SaveManager.Instance.Save();


        if (SaveManager.Instance.state.levelLife == 0)
        {
            StartCoroutine(GetAd());
        }
        else
        {
            StartCoroutine(GameOverUI());
        }    
    }

    // Show GameOverUI after x seconds
    private IEnumerator GameOverUI()
    {
        yield return new WaitForSeconds(2);
        gameOverUI.SetActive(true);

        inGameUI.SetActive(false);
    }

    //Show Ad ui after x seconds
    private IEnumerator GetAd()
    {
        yield return new WaitForSeconds(2);
        adUI.SetActive(true);
        yield return new WaitForSeconds(1);
        Admanager.Instance.GetLifeAd();
        Time.timeScale = 0;

    }

   void SetLifeText()
    {
        lifeText.text = life.ToString();
    }

}

