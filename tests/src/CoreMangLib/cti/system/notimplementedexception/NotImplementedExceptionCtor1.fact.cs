using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notimplementedexception_NotImplementedExceptionCtor1_NotImplementedExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_notimplementedexception_NotImplementedExceptionCtor1_NotImplementedExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notimplementedexception\\NotImplementedExceptionCtor1\\NotImplementedExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
