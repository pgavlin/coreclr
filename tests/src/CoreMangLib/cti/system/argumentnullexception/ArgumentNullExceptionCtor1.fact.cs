using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_argumentnullexception_ArgumentNullExceptionCtor1_ArgumentNullExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_argumentnullexception_ArgumentNullExceptionCtor1_ArgumentNullExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\argumentnullexception\\ArgumentNullExceptionCtor1\\ArgumentNullExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
