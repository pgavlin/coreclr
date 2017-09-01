using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_do_arithm64_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_do_arithm64_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_do\\arithm64_do.cmd");
        }
    }
}
