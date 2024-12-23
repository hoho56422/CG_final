#version 330 core
in vec4 particleColor; // Particle color passed from vertex shader
out vec4 FragColor;

uniform sampler2D flameTexture; // Texture for flame

void main() {
    vec2 texCoords = gl_PointCoord; // Get texture coordinates
    vec4 textureColor = texture(flameTexture, texCoords); // Sample the texture

    // Blend the particle color with the texture
    FragColor = textureColor * particleColor;

    // Optional: fade edges of the flame for smooth blending
    if (FragColor.a < 0.1) discard; // Discard nearly transparent fragments
}
