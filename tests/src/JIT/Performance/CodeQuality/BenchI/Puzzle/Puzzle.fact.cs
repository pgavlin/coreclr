using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_Puzzle_Puzzle_Puzzle_
    {
        [Fact]
        public void _CodeQuality_BenchI_Puzzle_Puzzle_Puzzle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Puzzle\\Puzzle\\Puzzle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
