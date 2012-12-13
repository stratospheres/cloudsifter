/*-----------------------------------------------------------------------------
Matrix Responsive HTML Template - Javascript Functions
-------------------------------------------------------------------------------
Version : 1.0.1
Date : 23 / 08 / 2012
Author : Billy Foo
-----------------------------------------------------------------------------*/

$(document).ready(function(){
	
	// Color changer
	$(".cblue").click(function(){
       $("link#clink").attr("href", "css/style-blue.css");
       return false;
    });
	$(".cred").click(function(){
       $("link#clink").attr("href", "css/style-red.css");
       return false;
    });
	$(".cgreen").click(function(){
       $("link#clink").attr("href", "css/style-green.css");
       return false;
    });
	$(".cmagenta").click(function(){
       $("link#clink").attr("href", "css/style-magenta.css");
       return false;
    });
	$(".cpurple").click(function(){
       $("link#clink").attr("href", "css/style-purple.css");
       return false;
    });
	$(".cteal").click(function(){
       $("link#clink").attr("href", "css/style-teal.css");
       return false;
    });
	$(".clime").click(function(){
       $("link#clink").attr("href", "css/style-lime.css");
       return false;
    });
	$(".cbrown").click(function(){
       $("link#clink").attr("href", "css/style-brown.css");
       return false;
    });
	$(".cpink").click(function(){
       $("link#clink").attr("href", "css/style-pink.css");
       return false;
    });
	$(".cmango").click(function(){
       $("link#clink").attr("href", "css/style-mango.css");
       return false;
    });
	
	//Navigation
	$("ul#nav li").hoverIntent(function(){
		$(this).children('ul').slideDown(300);
	},function(){
		$(this).children('ul').slideUp(300);
	});
		// Create the dropdown base
		$("<select />").appendTo("nav");
		
		// Create default option "Go to..."
		$("<option />", {
		   "selected": "selected",
		   "value"   : "",
		   "text"    : "Go to..."
		}).appendTo("nav select");
		
		// Populate dropdown with menu items
		$("nav a").each(function() {
		 var el = $(this);
		 $("<option />", {
			 "value"   : el.attr("href"),
			 "text"    : el.text()
		 }).appendTo("nav select");
		});
		
		$("nav select").change(function() {
		  window.location = $(this).find("option:selected").val();
		});
	
	//Flexslider	
    $('.flexslider').flexslider();
	
	//Masonry Settings
    $('#content-mos').masonry({
      itemSelector : '.tile',
      columnWidth : 160,
	  isAnimated: true,
	  isFitWidth: true
    });
	
  	//Allow effects when hovering on tiles
    $('.tile').not('.exclude').hover(function(){  
        $('.tile').not(this).addClass('fade');
    },     
    function(){    
        $('.tile').removeClass('fade');     
    });
	$('.tile').append('<img class="tilehover" src="images/tilehover.png" alt=" "/>');
		
	//Live-tile effects
	$(".live").liveTile({pauseOnHover: true});
	
	//Twitter on tile
		//Username
		var user = 'envato';
		//Number of tweets to be displayed
		var tweetcount = 4;
		$.getJSON('http://twitter.com/statuses/user_timeline.json?screen_name=' + user + '&count=' + tweetcount + '&callback=?', function(data){
        // Result
        var tweet = "";
		for (i = 0; i < data.length; i++) {
		tweet += "<li>" + data[i].text + "</li>";
		}
      
        // Links
        tweet = tweet.replace(/(\b(https?|ftp|file):\/\/[-A-Z0-9+&@#\/%?=~_|!:,.;]*[-A-Z0-9+&@#\/%=~_|])/ig, function(url) {
            return '<a target="_blank" href="'+url+'">'+url+'</a>';
        }).replace(/B@([_a-z0-9]+)/ig, function(reply) {
            return  reply.charAt(0)+'<a href="http://twitter.com/'+reply.substring(1)+'">'+reply.substring(1)+'</a>';
        });
        // Output
        $("#tweeter").html(tweet);
		});
				
	//Toggle
	$(".toggle-button").click(function(){
		$(this).next("div.toggle-content").slideToggle("slow");
		$(this).children('.toggle-indicator').text($(this).children('.toggle-indicator').text() == '+' ? '-' : '+');
	});
	
	//Accordion
	$(".accordion .ac-tab").click(function(){
		$(this).next("div.toggle-content").slideToggle("slow").siblings("div.toggle-content").slideUp("slow");
		$(this).children('.toggle-indicator').text('-')
		$(this).siblings().children('.toggle-indicator').text('+');
	});
	
	//Table
	$(".table-info ul li").hoverIntent(function(){
		$(this).next("div.table-details").slideDown("slow").siblings("div.table-details").slideUp("slow");
		$(this).children('.toggle-indicator').text('-')
		$(this).siblings().children('.toggle-indicator').text('+');
	},function(){
		
	});
	$(".table-info ul").mouseleave(function(){
		$(this).children('div.table-details').slideUp('slow');
		$(this).find('.toggle-indicator').text('+');
	});
		
	//Lightbox
	$("a.lightbox").click(function(){
		$(this).next(".tile-pre").addClass("tempsrc");
	});
	var lbSRC ="";
	$("a.lightbox").fancybox({
		'margin' : 0 ,
		'overlayColor' : '#000',
		'transitionIn': 'elastic',
		'transitionOut': 'elastic',
		'speedOut': 100,
		'cyclic' : true,
		//Lightbox iframe fix
		'onComplete': function() {
		lbSRC = $('#fancybox-content').find('iframe').attr('src');
		},
		'onClosed': function() {
		$('.tempsrc').find('iframe').attr('src',lbSRC);
		$('.tile-pre').removeClass('tempsrc');
		}
	});
	
	//Post Meta
	var pathname = window.location.protocol + "//" + window.location.host + window.location.pathname;
	// Get Number of Facebook Shares
    $.getJSON('http://graph.facebook.com/?id='+pathname+'',
        function(data) {
			if( data.shares == undefined){
            $('.meta2 .count').prepend('0');
			}else{
			$('.meta2 .count').prepend(data.shares);
			}
    });

    // Get Number of Tweet Count
    $.getJSON('http://urls.api.twitter.com/1/urls/count.json?url='+pathname+'&callback=?',
        function(data) {
            $('.meta3 .count').prepend(data.count);
    });
	
	
	//Bloglist
	$('.bloglist').hover(function(){
		$(this).css({'margin-top' : '-5px'});
	},
	function(){
		$(this).css({'margin-top' : '0'});
	});
	
	//Portfoliolist
	 $('ul#port-filter a').click(function() {  
        $(this).css('outline','none');  
        $('ul#port-filter .filter-current').removeClass('filter-current');  
        $(this).parent().addClass('filter-current');  
          
        var filterVal = $(this).text().toLowerCase().replace(' ','-');  
                  
        if(filterVal == 'all') {  
			$('div.hidden').fadeIn('fast').removeClass('hidden');  
        } else {  
            $('div#portfolio div.tile').each(function() {  
                if(!$(this).hasClass(filterVal)) {  
                    $(this).fadeOut('fast').addClass('hidden');  
                } else {  
                    $(this).fadeIn('fast').removeClass('hidden');  
                }  
            });
			$('div.portfoliolist').each(function() {  
                if(!$(this).hasClass(filterVal)) {  
                    $(this).fadeOut('fast').addClass('hidden');  
                } else {  
                    $(this).fadeIn('fast').removeClass('hidden');  
                }  
            });  
        }  
          
        return false;  
    });
	
	//Organic Tabs
	$("#demo-button").organicTabs();
	$("#demo-tab").organicTabs();
    
	//Check for placeholder
	// Released under MIT license: http://www.opensource.org/licenses/mit-license.php
	$('[placeholder]').focus(function() {
	  var input = $(this);
	  if (input.val() == input.attr('placeholder')) {
		input.val('');
		input.removeClass('placeholder');
	  }
	}).blur(function() {
	  var input = $(this);
	  if (input.val() == '' || input.val() == input.attr('placeholder')) {
		input.addClass('placeholder');
		input.val(input.attr('placeholder'));
	  }
	}).blur().parents('form').submit(function() {
	  $(this).find('[placeholder]').each(function() {
		var input = $(this);
		if (input.val() == input.attr('placeholder')) {
		  input.val('');
		}
	  })
	});
	
});

