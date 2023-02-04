using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Story Point", menuName = "story/story points/story point")]
public class StoryPoint : GamePoint
{

    [field: SerializeField]
    public string Title { get; private set; }

    [field: SerializeField]
    public string Story { get; private set; }

    [field: SerializeField]
    public Sprite Background { get; private set; }

    [field: SerializeField]
    public Color BackgroundColor { get; private set; } = Color.white;

    [field: SerializeField]
    public Color TextColor { get; private set; } = Color.white;

    [field: SerializeField]
    public AudioClip Music { get; private set; }

    [field: SerializeField]
    public List<Decision> Decisions { get; private set; }

    [field: SerializeField]
    public float DecisionTime { get; private set; } = -1;

    [field: SerializeField]
    public Decision DefaultDecision { get; private set; } = null;

    [field: SerializeField]
    public bool AddStoreOptions { get; private set; } = false;

}
