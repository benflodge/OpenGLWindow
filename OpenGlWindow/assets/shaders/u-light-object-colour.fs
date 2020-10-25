#version 330 core
out vec4 FragColour;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main()
{
	FragColour = vec4(lightColor * objectColor, 1.0);
}