using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_array1_array1_
    {
        [OuterLoop]
        [Fact]
        public void _refany_array1_array1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\array1\\array1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
