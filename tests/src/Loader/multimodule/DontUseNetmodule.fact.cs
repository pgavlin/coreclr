using CoreclrTestLib;
using Xunit;

namespace Loader_multimodule
{
    public class _DontUseNetmodule_DontUseNetmodule_
    {
        [OuterLoop]
        [Fact]
        public void _DontUseNetmodule_DontUseNetmodule_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\multimodule\\DontUseNetmodule\\DontUseNetmodule.cmd");
        }
    }
}
