﻿// 颜色加深
function fuscous(obj)
{
    obj.style.backgroundColor='#D3DEEF';
}

//颜色恢复为白色
function undertone(obj)
{
    obj.style.backgroundColor='#ffffff';     
}

//全选及全不选
function chooseAll(sel,check)
{   
    var obj = showModalDialog(url,arguments,'dialogWidth:'+width+'px; dialogHeight:'+height+'px;help:0;status:0;resizeable:1');
    if(obj == 'OK')
    {
        document.getElementById(arguments).click();
    }
}