using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIConvertibleToUint64_EnumIConvertibleToUint64_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIConvertibleToUint64_EnumIConvertibleToUint64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIConvertibleToUint64\\EnumIConvertibleToUint64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
