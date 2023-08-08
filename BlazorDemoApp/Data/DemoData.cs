using BlazorDemoApp.Shared.Data;

namespace BlazorDemoApp.Data;

public static class DemoData
{
    public static List<Product> Products()
    {
        return new List<Product>
        {
            new()
            {
                Id = 1, Title = "Smart speaker", Price = 22m, Images = new List<string> { "test-image.png" },
                Description =
                    "This smart speaker delivers excellent sound quality and comes with built-in voice control, offering an impressive music listening experience.",
                Related = new() { 2, 3 }
            },
            new()
            {
                Id = 2, Title = "Regular speaker", Price = 89m, Images = new List<string> { "test-image.png" },
                Description =
                    "Enjoy room-filling sound with this regular speaker. With its slick design, it perfectly fits into any room in your house.",
                Related = new() { 1, 3 }
            },
            new()
            {
                Id = 3, Title = "Speaker cable", Price = 12m, Images = new List<string> { "test-image.png" },
                Description =
                    "This high-quality speaker cable ensures a reliable and clear audio connection for your sound system."
            },
            new()
            {
                Id = 4, Title = "T-Shirt", Price = 32m, Images = new List<string> { "test-image.png" },
                Description =
                    "Show your style with this comfortable and modern T-Shirt, made from cotton for maximum comfort."
            },
            new()
            {
                Id = 5, Title = "Large TV", Price = 119.90m, Images = new List<string> { "test-image.png" },
                Description =
                    "Experience the best of entertainment with this large TV. It offers great picture quality and multi-channel sound for an immersive viewing experience.",
                Related = new(){2, 6, 7, 8, 9, 10, 14}
            },
            new()
            {
                Id = 6, Title = "Gaming Headset", Price = 49.99m, Images = new List<string> { "test-image.png" },
                Description =
                    "Experience superior sound clarity and deep, punchy bass for a wide soundscape with this gaming headset.",
                Related = new() { 7, 8 }
            },
            new()
            {
                Id = 7, Title = "Gaming Mouse", Price = 35m, Images = new List<string> { "test-image.png" },
                Description =
                    "Gaming mouse with ergonomic design, high-precision sensor, and customizable buttons for the perfect online gaming experience.",
                Related = new() { 6, 8 }
            },
            new()
            {
                Id = 8, Title = "Keyboard", Price = 79.99m, Images = new List<string> { "test-image.png" },
                Description =
                    "Experience comfortable typing with this keyboard, featuring soft-touch keys and an ergonomic layout.",
                Related = new() { 6, 7 }
            },
            new()
            {
                Id = 9, Title = "USB Microphone", Price = 69.99m, Images = new List<string> { "test-image.png" },
                Description = "Capture studio-quality audio for vocals, music, and more with this USB microphone.",
            },
            new()
            {
                Id = 10, Title = "Wireless Earbuds", Price = 129m, Images = new List<string> { "test-image.png" },
                Description =
                    "Enjoy superior sound quality and true cord-free convenience with these sleek and stylish wireless earbuds.",
            },
            new()
            {
                Id = 11, Title = "Digital Camera", Price = 449m, Images = new List<string> { "test-image.png" },
                Description =
                    "Capture stunning photos and video with this highly capable digital camera, packed with the latest technology.",
            },
            new()
            {
                Id = 12, Title = "Tripod", Price = 38.50m, Images = new List<string> { "test-image.png" },
                Description =
                    "Ensure stable and adjustable positioning for your camera with this durable and easy-to-use tripod.",
            },
            new()
            {
                Id = 13, Title = "Portable Charger", Price = 24.99m, Images = new List<string> { "test-image.png" },
                Description =
                    "Stay charged on the go with this compact and lightweight portable charger, suitable for a variety of devices.",
            },
            new()
            {
                Id = 14, Title = "USB-C Cable", Price = 14.99m, Images = new List<string> { "test-image.png" },
                Description = "Fast and durable charging cable with USB-C connector for your latest gadgets.",
            },
            new()
            {
                Id = 15, Title = "Bluetooth Speaker", Price = 59.99m, Images = new List<string> { "test-image.png" },
                Description =
                    "Enjoy your favorite music on the go with this Bluetooth speaker, offering powerful sound and long battery life.",
            },
        };
    }
}