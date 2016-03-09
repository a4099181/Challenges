# SwapBlocks

> how to swap two (rather not equal) parts of one array nice and fast. Requirement: _don't use any other array_.

## Input

Type | Synopsis | Example value
---|---|--:
Array | array of something | `JohnDoe`
int | first block size | `4`
 | **Expected result** | `DoeJohn`

## Implemented algorithms

Let's get `BenLawrence` as input and `3` as first block size.
* The goal is to move `3` first chars to the end of the input array.

### Linq

Extremely simple solution: take all but skip first `3` items and merge with first `3` items.

> [Linq/SwapBlocks.cs](Linq/SwapBlocks.cs)

### Non-Linq

#### Triple-reverse

1. Reverse first `3` chars.
2. Reverse all chars after `3`.
3. Reverse all items.

And that's all.

> [Arrays/SwapBlocksTripleReverse.cs](Arrays/SwapBlocksTripleReverse.cs)

#### Swapping blocks

Short explanation using an example:

* `BenLawrence` length is `11`
* With some simplification `BenLawrence` is splitted into equal blocks with size of `3`.

  ```
  [Ben] [Law] [ren] {ce}
  ```
  
  Then first block is swapped with the next as long as it is possible. 
  
  ```
  [Law] [Ben] [ren] {ce}
  [Law] [ren] [Ben] {ce}
  ```
  
  All before `[Ben]` is on right place now, but current array is `LawrenBence`. So that's not the end yet.
  Now alogrithm is going to repeat the same operation as above but in opposite direction and input is `Bence` and first (last) block size is now `2`. 
  
  ```
  Lawren {B} [en] [ce]
  Lawren {B} [ce] [en]
  ```
  
  All after `[ce]` is on the right place now, but current array is `LawrenBceen`. Still not good.
  Now alogrithm is going to repeat again the same operation with opposite direction and new input `Bce` and `1` as first block size.
  
  ```
  Lawren [B] [c] [e] en
  Lawren [c] [B] [e] en
  Lawren [c] [e] [B] en
  ```
  
  All is done. The result is `LawrenceBen`.
  
  All above is simplified description of algorithm implemented at:
  
  > [Arrays/SwapBlocks.cs](Arrays/SwapBlocks.cs)
  
  > [Arrays/SwapBlocksUnsafe.cs](Arrays/SwapBlocksUnsafe.cs)
  
  This solution may be simply realised with more than one threads:
  
  > [Arrays/SwapBlocksMta.cs](Arrays/SwapBlocksMta.cs)
  
  > [Arrays/SwapBlocksParallel.cs](Arrays/SwapBlocksParallel.cs)
  
## Benchmarks

> [Benchmark report](../Benchmarks/SwapBlocksBench-report-github.md)

Fastest solution is ... triple-reverse. Surprised? The winner is `Array.Reverse` method. It internally invokes very fast unmanaged native code. That's why triple-reverse wins. 
