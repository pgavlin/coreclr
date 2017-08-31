using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_argumentexception_ArgumentExceptionCtor1_ArgumentExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_argumentexception_ArgumentExceptionCtor1_ArgumentExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\argumentexception\\ArgumentExceptionCtor1\\ArgumentExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
