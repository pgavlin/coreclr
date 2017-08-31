using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIConvertibleToType_EnumIConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIConvertibleToType_EnumIConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIConvertibleToType\\EnumIConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
