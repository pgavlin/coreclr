using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_null_box_unbox_null006_box_unbox_null006_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_null_box_unbox_null006_box_unbox_null006_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\null\\box-unbox-null006\\box-unbox-null006.cmd");
        }
    }
}
