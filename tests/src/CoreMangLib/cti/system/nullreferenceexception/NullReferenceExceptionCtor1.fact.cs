using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_nullreferenceexception_NullReferenceExceptionCtor1_NullReferenceExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_nullreferenceexception_NullReferenceExceptionCtor1_NullReferenceExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\nullreferenceexception\\NullReferenceExceptionCtor1\\NullReferenceExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
