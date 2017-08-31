using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_406160_DevDiv_406160_DevDiv_406160_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_406160_DevDiv_406160_DevDiv_406160_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_406160\\DevDiv_406160\\DevDiv_406160.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
