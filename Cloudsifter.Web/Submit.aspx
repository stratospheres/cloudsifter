<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Submit.aspx.cs" Inherits="Cloudsifter.Web.Submit" %>
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title>Cloudsifter - Cloud news from Adam Hoffman and friends, submit your link!.</title>
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
                        <h1>Ready to submit a link?</h1>
                        <p>
                            This site is interesting because of you, dear link submitter.  Help me keep this interesting for our friends
                            by helping me to spot the most interesting links you come across in your daily surfing.  If you bring me a link
							that ends up getting used, I'll even give you credit, and put up a link to your site along with the link, 
                            so that you can bask in the internet glory!  Note: this is optional.  If you'd like to bathe in anonymity, that's OK too.
                        </p>
                    </header>
                    <section>
                        <h2>Take credit</h2>
                        <p>
                            I'm always ready to take your links.  Just fill in the fields below to let me know what you find interesting.
                            Week by week, I'll sort through all the submissions, prune them a little to de-duplicate and generally clean
                            up the data, and put them back out in the form of an email newsletter that I'll mail you (if you want to <a href="/subscribe" target="_blank">subscribe</a>
                            or just on the site, if you prefer to come back here to read them.  
                        </p>
                        <p>
                            I ask that you fill in your name below, so that you can receive some credit if you'd like, but you can feel 
                            free to be &quot;Anonymous&quot; if that's more your style.  If you'd like some reverse link traffic, give me a URL
                            for yourself - I'd prefer that it's to your own blog or a profile page somewhere rather than to some overtly commercial
                            site, but if you are a business (maybe a consultant or whatever), then I'm happy to point to your company site, or
                            even to that of your employer.  You link my back, I'll link yours, or something like that. As far as the link goes, I'll 
                            need the URL at least, but if you'd like to give me a title and description to help me understand your read of it, all the better.  
                        </p>
                    </section>
<% } %>
                    <section>
<% if (IsFirstTime) {  %>
                        <h3>Now, it's your turn.  Your link's details go here...</h3>
                        <div id="form-wrapper">
                        <form id="detailsform" action="/submit" method="post" runat="server" >  
                            <fieldset>  
                                <legend>Your Information</legend>
                                <div>
                                    <label for="name" id="name_label">Your Full Name *</label>  
                                    <input type="text" name="name" id="name" size="50" value="" class="text-input required" title="We need your name, or just make something up. :)"/>  
                                </div>
                                <div>
                                    <label for="website" id="email_label">Your Website (if you want a linkback - this is not the link that you're submitting, optional)</label>  
                                    <input type="text" name="website" id="website" size="50" value="" class="text-input url" title="Must be a valid URL." />  
                                </div>
                            </fieldset>  
                            <fieldset>  
                                <legend>Your Link's Information</legend>
                                <div>
                                    <label for="url" id="url_label">Your link (URL) *</label>  
                                    <input type="text" name="url" id="url" size="50" value="" class="text-input required url" title="Field is required and must be a valid URL."/>  
                                </div>
                                <div>
                                    <label for="title" id="title_label">A title for your link (optional)</label>  
                                    <input type="text" name="title" id="title" size="50" value="" class="text-input" />  
                                </div>
                                <div>
                                    <label for="description" id="description_label">A description for your link (optional)</label>  
                                    <input type="text" name="description" id="description" size="50" value="" class="text-input" />  
                                </div>
                            </fieldset>  
                            <div>  
                                <input type="submit" name="submit" class="button" id="submit_btn" value="Send" onclick="javascript:saveCookies();" />  
                            </div>
                        </form>  
                        </div>
<% } else { %>
                        <div>Thanks for your submission!  Click here to <a href="/submit">submit</a> another!</div>
<% } %>
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
                    // preload known values from cookies if they exist...
                    $("#name").val($.cookie("name"));
                    $("#website").val($.cookie("website"));

                    function saveCookies() {
                        $.cookie("name", $("#name").val());
                        $.cookie("website", $("#website").val());
                    }
                </script>
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
