using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringTrim2_StringTrim2_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringTrim2_StringTrim2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringTrim2\\StringTrim2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
