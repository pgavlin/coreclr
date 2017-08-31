using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_Base01b_seq_Base01b_seq_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_Base01b_seq_Base01b_seq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\Base01b_seq\\Base01b_seq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
