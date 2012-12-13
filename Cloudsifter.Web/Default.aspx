<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cloudsifter.Web.Default" %>
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

        <script src="/js/vendor/modernizr-2.6.1-respond-1.1.0.min.js"></script>
    </head>
    <body>
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
                    <header>
                        <h1>hello...</h1>
                        <p>
                            Welcome to Cloudsifter, a curated list of the most interesting links related to cloud software development,
                            as discovered by you, the readers, and me, the curator.  
                        </p>
                    </header>
                    <section>
                        <h2>What's the story?</h2>
                        <p>
                            Great question.  The story (or stories) told here are those that you bring, and that this site helps to 
                            archive and make available.  Think of it as your surfing buddy, always on the lookout for the most interesting
                            cloud development stuff that you <strong>should</strong> be reading, but might just miss on your own.
                        </p>
                    </section>
                    <section>
                        <h2>OK, so show me the stories.</h2>
                        <p>
                            Gladly, dear reader.  But before we get started, let's discuss the three basic things that you need to know:    
                        </p>
                        <ol>
                            <li>The latest stories are <a href="/latest">here</a>.  If you want to subscribe so that you get them as soon as they're ready, you can do that <a href="/subscribe">here</a>.</li>
                            <li>Older stuff that you might want to catch up on is <a href="/past">here</a>.</li>
                            <li>Submit stuff that you think is interesting <a href="/submit">here</a>.  If you tell me who you are and I use it, you get the credit.  Give me a URL for your site, and I'll link back to you too.</li>
                        </ol>
                    </section>
                </article>

                <aside>
                    <h3><a href="/latest">Take me to the latest issue...</a></h3>
                    <p>
                        Ready for the latest, greatest stuff we've got on tap?  Me too.  They're right <a href="/latest">here</a>.
                    </p>
                    <iframe
                    style="width: 300px; height: 250px; border: 0; border-style: none;"
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
