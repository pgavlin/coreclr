using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_d_arithm64_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_d_arithm64_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_d\\arithm64_d.cmd");
        }
    }
}
