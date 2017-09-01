using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_box_unbox_box_unbox003_box_unbox003_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_box_unbox_box_unbox003_box_unbox003_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\box-unbox\\box-unbox003\\box-unbox003.cmd");
        }
    }
}
