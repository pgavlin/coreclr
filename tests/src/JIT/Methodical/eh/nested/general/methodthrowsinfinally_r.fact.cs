using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_methodthrowsinfinally_r_methodthrowsinfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_methodthrowsinfinally_r_methodthrowsinfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\methodthrowsinfinally_r\\methodthrowsinfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
