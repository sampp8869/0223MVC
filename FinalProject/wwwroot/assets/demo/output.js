{
  "#comment": "",
  "html": {
    "@lang": "zh-tw",
    "head": {
      "meta": {
        "@charset": "UTF-8"
      },
      "title": "HW2",
      "style": ".box {\r\n            margin: 20px auto;\r\n            width: 250px;\r\n        }\r\n\r\n        .box1 {\r\n            border: 2px dashed red;\r\n            margin: 20px auto;\r\n            width: 500px;\r\n            padding: 20px 20px;\r\n        }\r\n\r\n        h1,\r\n        h2 {\r\n            font-family: 'Times New Roman', Times, serif;\r\n            text-align: center;\r\n\r\n        }\r\n\r\n        .list {\r\n\r\n            overflow: auto;\r\n            list-style-type: none;\r\n\r\n        }\r\n\r\n        .list li {\r\n            width: 50px;\r\n            float: left;\r\n        }\r\n\r\n        .list li a {\r\n            text-align: center;\r\n        }\r\n\r\n        .note {\r\n            color: gray;\r\n            border-bottom: 1px dashed gray;\r\n            width: 500px;\r\n\r\n        }"
    },
    "body": {
      "h1": "JS_HW2",
      "div": {
        "@class": "box",
        "ul": {
          "@class": "list",
          "li": [
            {
              "a": {
                "@href": "HW1.html",
                "#text": "HW1"
              }
            },
            {
              "a": {
                "@href": "HW3.html",
                "#text": "HW3"
              }
            },
            {
              "a": {
                "@href": "HW4.html",
                "#text": "HW4"
              }
            },
            {
              "a": {
                "@href": "HW5.html",
                "#text": "HW5"
              }
            }
          ]
        }
      },
      "fieldset": {
        "@class": "box1",
        "legend": "Form Check",
        "label": [
          "姓名:",
          "密碼:",
          "日期:"
        ],
        "input": [
          {
            "@type": "text",
            "@id": "idName",
            "@required": "",
            "@size": "12"
          },
          {
            "@type": "password",
            "@id": "idPwd",
            "@required": "",
            "@size": "12"
          },
          {
            "@type": "text",
            "@id": "idDate",
            "@required": "",
            "@size": "12"
          }
        ],
        "span": [
          {
            "@id": "idna"
          },
          {
            "@id": "idsp"
          },
          {
            "@id": "idda"
          }
        ],
        "p": [
          {
            "@class": "note",
            "#text": "(1.不可空白2.至少2個字以上3.必須全部為中文)"
          },
          {
            "@class": "note",
            "#text": "(1.不可空白2.至少6個字且必須包含英文、數字、特殊字元[!@#$%^&*])"
          },
          {
            "@class": "note",
            "#text": "格式:西元年/月/日(yyyy/mm/dd)"
          }
        ],
        "br": [
          "",
          "",
          ""
        ],
        "#comment": ""
      },
      "script": "document.getElementById(\"idName\").addEventListener(\"blur\", checkName);\r\n        document.getElementById(\"idPwd\").addEventListener(\"blur\", checkPwd);\r\n        document.getElementById(\"idDate\").addEventListener(\"blur\", checkDate);\r\n        document.getElementById(\"idna\").style.color = \"red\";\r\n        document.getElementById(\"idsp\").style.color = \"red\";\r\n        document.getElementById(\"idda\").style.color = \"red\";\r\n\r\n        function checkName() {\r\n            let thePwdObjVal = document.getElementById(\"idName\").value;\r\n            let na = document.getElementById(\"idna\");\r\n            let thePwdObjValLen = thePwdObjVal.length;\r\n            let re = /^[\\u4e00-\\u9fa5]+$/\r\n\r\n            if (thePwdObjVal == \"\")\r\n                na.innerHTML = \"<img src='Images/error.png'/>姓名不可空白\";\r\n\r\n            else if (thePwdObjValLen >= 2) {\r\n                if (re.test(thePwdObjVal)) {\r\n                    na.style.color = \"green\";\r\n                    na.innerHTML = \"正確\";\r\n                }\r\n                else\r\n                    na.innerHTML = \"<img src='Images/error.png'/>姓名必須都為中文\";\r\n            }\r\n            else\r\n                na.innerHTML = \"<img src='Images/error.png'/>最少兩個字\";\r\n\r\n        }\r\n\r\n        function checkPwd() {\r\n            let thePwdObj = document.getElementById(\"idPwd\");\r\n            let thePwdObjVal = thePwdObj.value;\r\n            let sp = document.getElementById(\"idsp\");\r\n            let thePwdObjValLen = thePwdObjVal.length;\r\n            let ch, flag1 = false, flag2 = false, flag3 = false;\r\n            let re = /^[\\!\\@\\#\\$\\%\\^\\&\\*]+$/\r\n            if (thePwdObjVal == \"\")\r\n                sp.innerHTML = \"<img src='Images/error.png'/>密碼不可空白\";\r\n            else if (thePwdObjValLen >= 6) {\r\n                for (let i = 0; i < thePwdObjValLen; i++) {\r\n                    ch = thePwdObjVal.charAt(i).toUpperCase();\r\n                    if (ch >= \"A\" && ch <= \"Z\")\r\n                        flag1 = true;\r\n                    else if (ch >= \"0\" && ch <= \"9\")\r\n                        flag2 = true;\r\n                    else if (re.test(ch))\r\n                        flag3 = true;\r\n                    if (flag1 && flag2 && flag3) break;\r\n                }\r\n                if (flag1 && flag2 && flag3) {\r\n                    sp.style.color = \"green\";\r\n                    sp.innerHTML = \"符合密碼規則\";\r\n                }\r\n                else\r\n                    sp.innerHTML = \"<img src='Images/error.png'/>不符合密碼規則\";\r\n            }\r\n\r\n            else\r\n                sp.innerHTML = \"<img src='Images/error.png'/>密碼最少六位\"\r\n\r\n        }\r\n\r\n        function checkDate() {\r\n            let DateObjVal = document.getElementById(\"idDate\").value;\r\n            let sp = document.getElementById(\"idda\");\r\n            let d = new Date(DateObjVal);\r\n            let theyear = d.getFullYear();\r\n            let themonth = d.getMonth() + 1;\r\n            let theday = d.getDate();\r\n\r\n            let checkDate = `${theyear}/${themonth}/${theday}`;\r\n            if (DateObjVal == \"\")\r\n                sp.innerHTML = \"<img src='Images/error.png'/>不可為空白\";\r\n            else if (checkDate == DateObjVal) {\r\n                sp.style.color = \"green\";\r\n                sp.innerHTML = \"日期正確\";\r\n            }\r\n            else\r\n                sp.innerHTML = \"<img src='Images/error.png'/>無此日期\";\r\n\r\n\r\n        }"
    }
  },
  "#text": "HW2.html"
}