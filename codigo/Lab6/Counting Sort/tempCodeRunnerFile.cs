for (int i = n - 1; i >= 0; i--) 
            {
                output[count[vet[i]] - 1] = vet[i];
                --count[vet[i]];
            }