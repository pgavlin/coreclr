using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_245191_nullenum1000_nullenum1000_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_245191_nullenum1000_nullenum1000_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\245191\\nullenum1000\\nullenum1000.cmd");
        }
    }
}
