using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator 
{
    private static DialogueSystem dialogue_system;
    public static void SetDialogueSystem(DialogueSystem ds) { dialogue_system = ds; }
    public static DialogueSystem GetDialogueSystem() { return dialogue_system; }


    private static CharacterManager character_manager;
    public static void SetCharacterManager(CharacterManager cm) { character_manager = cm; }
    public static CharacterManager GetCharacterManager() { return character_manager; }
}
