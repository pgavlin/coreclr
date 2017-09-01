using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_box_unbox_box_unbox002_box_unbox002_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_box_unbox_box_unbox002_box_unbox002_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\box-unbox\\box-unbox002\\box-unbox002.cmd");
        }
    }
}
