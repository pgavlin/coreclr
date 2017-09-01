using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _valuetypes_nullable_box_unbox_enum_box_unbox_enum001_box_unbox_enum001_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_enum_box_unbox_enum001_box_unbox_enum001_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\enum\\box-unbox-enum001\\box-unbox-enum001.cmd");
        }
    }
}
