using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Opgave02.model;

public record PotterCharacter
{
    public required string FullName { get; set; }
    public required string Nickname { get; set; }
    public required string HogwartsHouse { get; set; }
    public required string InterpretedBy { get; set; }
    public required List<string> Children { get; set; }
    public required string Image {  get; set; }
    public required string Birthdate { get; set; }
    public required int Index { get; set; }
}