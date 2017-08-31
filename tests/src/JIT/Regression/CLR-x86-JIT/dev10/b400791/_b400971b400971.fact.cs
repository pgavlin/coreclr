using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b400791__b400971b400971__b400971b400971_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b400791__b400971b400971__b400971b400971_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b400791\\_b400971b400971\\_b400971b400971.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
