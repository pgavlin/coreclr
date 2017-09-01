using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_box_unbox_box_unbox004_box_unbox004_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_box_unbox_box_unbox004_box_unbox004_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\box-unbox\\box-unbox004\\box-unbox004.cmd");
        }
    }
}
