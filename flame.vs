#version 330 core
layout (location = 0) in vec3 aPos;       // Position of the particle
layout (location = 1) in vec4 aColor;    // Color of the particle
layout (location = 2) in float aSize;    // Size of the particle

out vec4 particleColor; // Pass color to fragment shader

uniform mat4 model;     // Model matrix for particles
uniform mat4 view;      // View matrix
uniform mat4 projection; // Projection matrix

void main() {
    gl_Position = projection * view * model * vec4(aPos, 1.0);
    gl_PointSize = aSize; // Set particle size
    particleColor = aColor;
}
