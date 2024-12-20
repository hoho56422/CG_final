#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D particleTexture;

void main() {
    vec4 texColor = texture(particleTexture, TexCoords);
    if (texColor.a < 0.1) discard; // 透明度裁剪
    FragColor = texColor;
}
