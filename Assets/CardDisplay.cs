using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public TMPro.TextMeshProUGUI nameText;
	public TMPro.TextMeshProUGUI descriptionText;
	public TMPro.TextMeshProUGUI manaText;
	public TMPro.TextMeshProUGUI healthText;
	public TMPro.TextMeshProUGUI attackText;

	public Image artwork;

	// Use this for initialization
	void Start () {
		nameText.text = card.cardName;
		descriptionText.text = card.description;
		manaText.text = card.manaCost.ToString ();
		healthText.text = card.health.ToString ();
		attackText.text = card.attack.ToString ();
		artwork.sprite = card.artwork;
	}
}
