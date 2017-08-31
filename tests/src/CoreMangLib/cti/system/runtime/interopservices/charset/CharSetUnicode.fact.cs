using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_charset_CharSetUnicode_CharSetUnicode_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_charset_CharSetUnicode_CharSetUnicode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\charset\\CharSetUnicode\\CharSetUnicode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
