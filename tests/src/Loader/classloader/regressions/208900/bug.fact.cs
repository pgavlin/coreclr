using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_208900_bug_bug_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_208900_bug_bug_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\208900\\bug\\bug.cmd");
        }
    }
}
