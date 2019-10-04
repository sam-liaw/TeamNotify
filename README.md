# TeamNotify 是開發來由程式來通知微軟推出的「Microsoft Teams」通訊軟體  
微軟推出的「Microsoft Teams」，它的功能和 Slack 很相似。  
使用他的原因，是因為先前使用 LINE 通知，每個月有 1000 筆訊息的限制。  
Slack 好像也有一個月 10000 筆訊息的限制。  
由於團隊人員越來越多，限制的筆數在某一天爆了，所以就開始了使用這個工具，  
作為一個通知工具，也沒什麼好挑剔的，唯一可以抱怨的就是記憶體的使用量有點高。  
有興趣的人去瞭解一下「Microsoft Teams」他的功能，免費的有空可以試一下。  
![](https://c.s-microsoft.com/zh-tw/CMSImages/Hero_TeamsFreemium_960x615.png?version=336ee2fa-042f-6bed-64c7-497aac979406 =550x)  
[Microsoft Teams 官方下載頁](https://products.office.com/zh-tw/microsoft-teams/free)  
使用上蠻簡單的，下面有範例程式碼：  
``` c#
Dictionary<int, string> dicUrl = new Dictionary<int, string>()
{
    {1 頻道,"https://IncomingWebhook 的網址" }
};
TeamNotify.Team notify_ = new TeamNotify.Team(dicUrl);
notify_.TeamNotify($"開機", 1 頻道, "通知來源");
```
這樣幾行就能進行通知了  

# JANDI 是類似「Microsoft Teams」通訊軟體  
記憶體用量比微軟少很多  
免費的，使用上也蠻好上手  
有興趣的可以去瞭解一下  
[JANDI 官方下載頁](https://www.jandi.com/landing/zh-tw)  
``` c#
Dictionary<int, string> dicUrl = new Dictionary<int, string>()
{
    {1 頻道,"https://IncomingWebhook 的網址" }
};
TeamNotify.JANDI notify_ = new TeamNotify.JANDI(dicUrl);
notify_.Notify($"開機", 1 頻道, "通知來源");
```

使用上同「Microsoft Teams」只要這樣幾行就能進行通知了  


###### tags: `Microsoft Teams` `JANDI`

