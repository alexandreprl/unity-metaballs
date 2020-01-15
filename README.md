# Unity-Metaballs

Made following the awesome tutorial at http://patomkin.com/blog/metaball-tutorial/.

Basically, each drop is a circle with a gradient going from the center (opaque) to the border (transparent). 
Then a shader is used such as when pixels are opaque enough then a color is applied. 
Therefore, the center of the circles will always be colored but the borders will only be if two circles overlap.
After that, I modified the shader to add transparency by getting some inspiration from https://www.youtube.com/watch?v=YCi4BnnQV2s.
And finally I have added a trail renderer to each drop with the same color.