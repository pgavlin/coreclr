using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringGetEnumerator_StringGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringGetEnumerator_StringGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringGetEnumerator\\StringGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
