﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="Cloudsifter.Web.Subscribe" %>
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title>Cloudsifter - Cloud news from Adam Hoffman and friends.</title>
        <meta name="description" content="azure, windows azure, cloud, cloud development, microsoft, adam hoffman">
		<meta name="keywords" content="azure, windows azure, cloud, cloud development, microsoft, adam hoffman">
        <meta name="viewport" content="width=device-width">

		<!-- Omniture required meta tags -->
		<meta name="t_omni_extblogid" content="msstoextblogs2" />
		<meta name="t_omni_blogname" content="ahoffman" />
		<meta name="t_omni_market" content="UNITED STATES" />
		<meta name="t_omni_audience" content="DEVELOPER" />

        <link rel="stylesheet" href="/css/normalize.min.css">
        <link rel="stylesheet" href="/css/main.css">


    </head>
    <body>
<style>
    #form-wrapper {
	width:430px;
	border:1px solid #e2e2e2;
	background:#f1f1f1;
	padding:20px;
}
#form-wrapper div {
	clear:both;
	margin:1em 0;
}
#form-wrapper label {
	display:block;
	float:none;
	font-size:16px;
	width:auto;
}
form#detailsform input {
	border-color:#B7B7B7 #E8E8E8 #E8E8E8 #B7B7B7;
	border-style:solid;
	border-width:1px;
	padding:5px;
	font-size:16px;
	color:#333;
}
form#detailsform textarea {
	font-family:'Segoe UI', Tahoma, Helvetica, sans-serif;
	font-size:100%;
	padding:0.6em 0.5em 0.7em;
	border-color:#B7B7B7 #E8E8E8 #E8E8E8 #B7B7B7;
	border-style:solid;
	border-width:1px;
}
    form#detailsform fieldset legend 
    {
        font-weight: bolder;
    }
</style>
        <!--[if lt IE 7]>
            <p class="chromeframe">You are using an outdated browser. <a href="http://browsehappy.com/">Upgrade your browser today</a> or <a href="http://www.google.com/chromeframe/?redirect=true">install Google Chrome Frame</a> to better experience this site.</p>
        <![endif]-->

        <div class="header-container">
            <header class="wrapper clearfix">
                <h1 class="title">Welcome to Cloudsifter</h1>
                <nav>
                    <ul>
                        <li><a href="/subscribe">Subscribe</a></li>
                        <li><a href="/submit">Submit a Link</a></li> 
                        <li><a href="/past">Catch Up</a></li>
                    </ul>
                </nav>
            </header>
        </div>

        <div class="main-container">
            <div class="main wrapper clearfix">

                <article>
<% if (IsFirstTime) {  %>
                    <header>
                        <h1>Subscribe!</h1>
                        <p>
                            I'm really glad you asked.  Give me a little information about yourself (your email address), and I'll happily
                            send you the latest version of this newsletter as often as it's ready (hopefully that's about once a week).
                            Additionally, rest assured that your email address will <strong>never</strong> be shared with anyone else,
                            for any other purpose.  You're giving me this email address so that I can send you interesting links about 
                            cloud related topics, and for no other reason.  I get that, and I'll respect that.                       </p>
                    </header>
<% } %>
                    <section>
<% if (IsFirstTime) {  %>
                        <h3>OK, good.  This is where your email address goes...</h3>
                        <div id="form-wrapper">
                        <form id="detailsform" action="/subscribe" method="post" runat="server" >  
                            <fieldset>  
                                <legend>Your Information</legend>
                                <div>
                                    <label for="email" id="email_label">Your email address *</label>  
                                    <input type="text" name="email" id="email" size="50" value="" class="text-input required email" title="I need a valid email address here..."/>  
                                </div>
                            </fieldset>  
                            <div>  
                                <input type="submit" name="submit" class="button" id="submit_btn" value="Subscribe" />  
                            </div>
                        </form>  
                        </div>
<% } else {
	   if (IsAlreadySubscribed) { %>
                        <div>Thanks for your info, but it looks like you've already signed up (and I thank you for that)!</div>
<% } else { %>
	                    <div>Thanks for your info! Check your email for a validation email! You'll get a heaping helping of delicious linkage very soon!</div>
<% } } %>
                    </section>
                </article>
                <aside>
                    <iframe
                    style="width: 300px; height: 250px; border: 0; border-style: none;padding-top: 20px;"
                    allowtransparency="true"
                    scrolling="no"
                    frameborder="0"
                    src="http://linker.azurewebsites.net/default/notrack?size=300x250"></iframe>

                </aside>

            </div> <!-- #main -->
        </div> <!-- #main-container -->

        <div class="footer-container">
            <footer class="wrapper">
                <h3>&copy;2012, <a href="http://www.stratospher.es" target="_blank">Adam Hoffman</a></h3>
                <p>
                    Cloudsifter is an occasional newsletter containing curated links of interest to cloud developers, IT professionals, CTOs and maybe you.
                    It works because of you, the reader, and your willingness to share articles of interest with the other readers of this site.  If you subscribe
                    to this newsletter, I absolutely promise you that I will only contact you with the occasional newsletter containing these sorts of links,
                    and will never resell or redistribute your information.  You will not get solicited by <strong>anyone</strong> as a result of subscribing
                    to this newsletter.  If you prefer, you can simply catch up on the site, but remember to stop back often, as we'll have new stuff all the time.
                </p>
            </footer>
        </div>

                <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
                <script>window.jQuery || document.write('<script src="/js/vendor/jquery-1.8.2.min.js"><\/script>')</script>
                <script type="text/javascript" src="/js/vendor/jquery.validate.js"></script>  
                <script src="/js/vendor/modernizr-2.6.1-respond-1.1.0.min.js"></script>
                <script src="/js/vendor/jquery.cookie.js"></script>
                <script type="text/javascript">
                    SubmittingForm = function () {
                        alert("The form has been validated.");
                        $("#detailsform").submit();
                    }


                    $(document).ready(function () {
                        $("#detailsform").validate();
                    });

            </script>

        <script src="/js/main.js"></script>

		<!-- Hook up Omniture -->
		<script type="text/javascript" src="http://www.microsoft.com/feeds/omni_external_blogs.js"></script>
		<noscript>
		<a href="http://www.omniture.com" title="Web Analytics"><img src="http://mssto.112.207.net/b/ss/msstoextblogsnojs/1/H.20.2--NS/0" height="1" width="1" border="0" alt="" /></a>
		</noscript>

		<script type="text/javascript">

			var _gaq = _gaq || [];
			_gaq.push(['_setAccount', 'UA-36981523-1']);
			_gaq.push(['_trackPageview']);

			(function () {
				var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
				ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
				var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
			})();

		</script>
    </body>
</html>
