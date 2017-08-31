using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_Base02b_seq_Base02b_seq_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_Base02b_seq_Base02b_seq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\Base02b_seq\\Base02b_seq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
