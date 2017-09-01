using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_regress_vswhidbey_339415_339415_
    {
        [OuterLoop]
        [Fact]
        public void _gc_regress_vswhidbey_339415_339415_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\regress\\vswhidbey\\339415\\339415.cmd");
        }
    }
}
