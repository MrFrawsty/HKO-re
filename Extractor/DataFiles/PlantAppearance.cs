﻿namespace Extractor;

[SeanItem(3)]
public struct PlantAppearance {
    [SeanField(0)] public int Id { get; set; }
    [SeanField(1)] public string File { get; set; }
    [SeanField(2)] public string Name { get; set; }
}
