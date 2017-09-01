using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_r_arithm64_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_r_arithm64_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_r\\arithm64_r.cmd");
        }
    }
}
