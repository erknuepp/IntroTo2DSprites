using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator = gameObject.GetComponent<Animator>();

        // Create a French (France) CultureInfo object.
        CultureInfo frFr = new CultureInfo("fr-FR");

        DateTime dateTimeNow = DateTime.Now;

        var param = animator.parameters[0].name;

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"The state of ");
        stringBuilder.Append(param);
        stringBuilder.Append(" is ");

        if (animator.GetInteger(param) == 0)
        {
            stringBuilder.Append("Idle".ToLower());
        }
        else
        {
            stringBuilder.Append("Running".ToUpper());
        }
        stringBuilder.Append(" on ");
        stringBuilder.Append(
            string.Format(
                DateTimeFormatInfo.CurrentInfo,
                "{0}",
                dateTimeNow.ToString("f", frFr)));
        stringBuilder.Append(".");
        Debug.Log(stringBuilder.ToString());

    }
}
