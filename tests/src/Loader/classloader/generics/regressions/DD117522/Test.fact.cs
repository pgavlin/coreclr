using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_regressions_DD117522_Test_Test_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_DD117522_Test_Test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\DD117522\\Test\\Test.cmd");
        }
    }
}
