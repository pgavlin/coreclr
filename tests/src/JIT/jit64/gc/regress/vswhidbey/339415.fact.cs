using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_regress_vswhidbey_339415_339415_
    {
        [OuterLoop]
        [Fact]
        public void _gc_regress_vswhidbey_339415_339415_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\regress\\vswhidbey\\339415\\339415.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
