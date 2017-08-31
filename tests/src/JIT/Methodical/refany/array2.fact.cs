using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_array2_array2_
    {
        [OuterLoop]
        [Fact]
        public void _refany_array2_array2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\array2\\array2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
