// https://www.codewars.com/kata/54fe05c4762e2e3047000add

using System;

public class Ship(double draft, int crew) {
  private double _draft { get; } = draft;
  private int _crew { get; } = crew;

  public bool isWorthIt() {
    return (_draft - (_crew * 1.5)) > 20;
  }
}
