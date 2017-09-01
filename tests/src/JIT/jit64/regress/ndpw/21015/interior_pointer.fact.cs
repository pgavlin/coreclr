using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ndpw_21015_interior_pointer_interior_pointer_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ndpw_21015_interior_pointer_interior_pointer_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ndpw\\21015\\interior_pointer\\interior_pointer.cmd");
        }
    }
}
