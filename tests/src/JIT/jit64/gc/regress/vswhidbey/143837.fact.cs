using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_regress_vswhidbey_143837_143837_
    {
        [Fact]
        public void _gc_regress_vswhidbey_143837_143837_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\regress\\vswhidbey\\143837\\143837.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
