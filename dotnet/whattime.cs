var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String[] timestrings = new String[10]{
    "Yo, it's HH:mm, and you know what that means, my peeps! Time to light up and vibe.",
    "Ladies and gents, it's HH:mm, and the universe is alignin' with my flow.",
    "Rollin' through at HH:mm, 'cause regular clocks can't handle my style.",
    "Aight, fam, it's HH:mm, and the sun's blazing like my rhymes.",
    "Check it, it's HH:mm, and the stars are throwin' a party up in the sky.",
    "Fo' real, it's HH:mm, and I'm sippin' on my gin and juice.",
    "Listen up, y'all-it's HH:mm, and Snoop's in the house.",
    "Right now, it's HH:mm, and I'm chillin' like a villain.",
    "Peep this: HH:mm, and I'm still cookin' up beats.",
    "Snoopy D-O-double-G here-it's HH:mm, 'cause I'm forever cool.",
};


app.MapGet("/", (context) => {
    var currentTime = DateTime.Now.ToString("HH:mm");
    Random rnd = new Random();
    int idx  = rnd.Next(0, 10);

    String htmlbegin = "<html><head></head><body style='background-color: #90c0de;'><div style='display: flex; flex-direction: column; justify-content: center; align-items: center; text-align: center; height: 100%; color: #1c7bb7; font-family: Arial, serif; font-size: 3rem;'>";
    String htmlend = "</div></body></html>";
    String htmlout = htmlbegin+timestrings[idx].Replace("HH:mm", currentTime)+htmlend;
    return context.Response.WriteAsync(htmlout);
});

app.Run();
