using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_box_unbox_box_unbox043_box_unbox043_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_box_unbox_box_unbox043_box_unbox043_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\box-unbox\\box-unbox043\\box-unbox043.cmd");
        }
    }
}
