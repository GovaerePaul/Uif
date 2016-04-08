﻿using UnityEngine;
using UnityEngine.UI;

public class GraphicColorable : Colorable {
	Graphic graphic;

	void Awake () {
		graphic = GetComponent<Graphic>();
	}

	public override Color GetColor () {
		return graphic.color;
	}

	public override void SetColor (Color newColor) {
		graphic.color = newColor;
	}
}