using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumToString_EnumToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumToString_EnumToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumToString\\EnumToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
