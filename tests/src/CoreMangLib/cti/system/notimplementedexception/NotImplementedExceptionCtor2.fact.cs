using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_notimplementedexception_NotImplementedExceptionCtor2_NotImplementedExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_notimplementedexception_NotImplementedExceptionCtor2_NotImplementedExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\notimplementedexception\\NotImplementedExceptionCtor2\\NotImplementedExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
